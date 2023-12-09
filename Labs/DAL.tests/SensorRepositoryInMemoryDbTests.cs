using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;
using Xunit;
using Microsoft.EntityFrameworkCore;


namespace Labs.DAL.Tests
{
    public class SensorRepositoryInMemoryDbTests
    {
       

        private SensorContext MySqlInMemoryContext()
        {
            // Create DbContextOptions with MySQL in-memory database
            var options = new DbContextOptionsBuilder<SensorContext>()
                .UseMySql("Server=localhost;Database=SensorContext;User=root;Password=1809;", // Connection string
                    new MySqlServerVersion(new Version(8, 0, 23))) // MySQL server version
                .Options;
            
            var context = new SensorContext(options);

            // Open the connection to the in-memory database
            context.Database.OpenConnection();

            // Ensure that the database is created. This is useful for scenarios like unit testing.
            context.Database.EnsureCreated();

            // Return the configured context
            return context;
        }

        [Fact]
        public void Create_InputSensorWithId0_SetSensorId1()
        {
            // Arrange
            int expectedListCount = 1;
            var context =  MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            ISensorRepository repository = uow.Sensors;

            Sensor sensor = new Sensor()
            {
                SensorID = 1,
                Location = "test",
                Readings ={},
                Status  = StatusEnum.Active
            };

            //Act
            repository.Create(sensor);
            uow.Save();
            var factListCount = context.Sensors.Count();

            // Assert
            Assert.Equal(expectedListCount, factListCount);
        }

        [Fact]
        public void Delete_InputExistSensorId_Removed()
        {
            // Arrange
            int expectedListCount = 0;
            var context =  MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            ISensorRepository repository = uow.Sensors;
            Sensor sensor = new Sensor()
            {
                SensorID = 1,
                Location = "test",
                Readings ={},
                Status  = StatusEnum.Active
            };
            context.Sensors.Add(sensor);
            context.SaveChanges();

            //Act
            repository.Delete(sensor.SensorID);
            uow.Save();
            var factSensorCount = context.Sensors.Count();

            // Assert
            Assert.Equal(expectedListCount, factSensorCount);
        }

        [Fact]
        public void Get_InputExistSensorId_ReturnSensor()
        {
            // Arrange
            var context =  MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            ISensorRepository repository = uow.Sensors;
            Sensor expectedSensor = new Sensor()
            {
                //SensorId = 1,
                SensorID = 1,
                Location = "test",
                Readings ={},
                Status  = StatusEnum.Active
            };
            context.Sensors.Add(expectedSensor);
            context.SaveChanges();

            //Act
            var factSensor = repository.Get(expectedSensor.SensorID);

            // Assert
            Assert.Equal(expectedSensor, factSensor);
        }
    }
}