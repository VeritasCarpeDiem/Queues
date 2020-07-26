using System;

using Queues;

using Xunit;

namespace Queues.Tests
{
    public class QueueTests
    {
        Queue<int> queue;
        public QueueTests()
        {
            queue = new Queue<int>();
        }


        [Fact]
        public void EmptyQueueCountIsZeroTest()
        {
            Assert.Equal(0, queue.Count);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(1000000)]

        public void CountMatchesItemsAddedInQueue(int count)
        {
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(i);
            }


            Assert.Equal(count, queue.Count);

            if (count < 1)
            {
                Assert.Null(queue.Head);
            }
            else
            {
                Assert.NotNull(queue.Head);
            }

        }

        [Fact]
        public void EmptyQueuePeekThrowsExceptionTest()
        {
            Assert.Throws<Exception>(() => queue.Peek());

        }

        [Fact]

        public void EmptyDeqeueThrowsExceptionTest()
        {
            Assert.Throws<Exception>(() => queue.Dequeue());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void CountMatchesItemsRemovedFromQueue(int count)
        {
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 0; i < count / 2; i++)
            {
                queue.Dequeue();
            }

            Assert.Equal(count - (count/2),queue.Count);


        }
    }
}
