using Xunit;
using Microsoft.EntityFrameworkCore;
using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Impl;
using Labs.Repositories.Interfaces;
using Moq;

namespace Labs.DAL.Tests
{
    class TestSensorRepository
        : BaseRepository<Sensor>
    {
        public TestSensorRepository(DbContext context) : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {

        [Fact]
        public void Create_InputStreetInstance_CalledAddMethodOfDBSetWithStreetInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SensorContext>()
                .Options;
            var mockContext = new Mock<SensorContext>(opt);
            var mockDbSet = new Mock<DbSet<Sensor>>();
            mockContext
                .Setup(context =>
                    context.Set<Sensor>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            var repository = new TestSensorRepository(mockContext.Object);

            Sensor expectedSensor = new Mock<Sensor>().Object;

            //Act
            repository.Create(expectedSensor);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedSensor
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SensorContext>()
                .Options;
            var mockContext = new Mock<SensorContext>(opt);
            var mockDbSet = new Mock<DbSet<Sensor>>();
            mockContext
                .Setup(context =>
                    context.Set<Sensor>(
                        ))
                .Returns(mockDbSet.Object);
            // EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            // ISensorRepository repository = uow.Streets;
            var repository = new TestSensorRepository(mockContext.Object);

            Sensor expectedSensor = new Sensor() { SensorID = 1};
            mockDbSet.Setup(mock => mock.Find(expectedSensor.SensorID)).Returns(expectedSensor);

            //Act
            repository.Delete(expectedSensor.SensorID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedSensor.SensorID
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedSensor
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SensorContext>()
                .Options;
            var mockContext = new Mock<SensorContext>(opt);
            var mockDbSet = new Mock<DbSet<Sensor>>();
            mockContext
                .Setup(context =>
                    context.Set<Sensor>(
                        ))
                .Returns(mockDbSet.Object);

            Sensor expectedSensor = new Sensor() { SensorID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedSensor.SensorID))
                    .Returns(expectedSensor);
            var repository = new TestSensorRepository(mockContext.Object);

            //Act
            var actualStreet = repository.Get(expectedSensor.SensorID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedSensor.SensorID
                    ), Times.Once());
            Assert.Equal(expectedSensor, actualStreet);
        }
    }
}
