using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerTest
{
    [TestFixture]
    public class Model_Competition_NextTrackShould
    {
        private Competition _competition;
        [SetUp]
        public void SetUp()
        {
            _competition = new Competition();
        }
        [Test]
        public void NextTrack_EmptyQueue_ReturnNull()
        {
            var result = _competition.NextTrack();
            Assert.IsNull(result);
        }
        [Test]
        public void NextTrack_OneInQueue_ReturnTrack()
        {
            var t1 = new Track("test", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            _competition.Tracks.Enqueue(t1);
            var result = _competition.NextTrack();
            Assert.AreEqual(t1, result);
        }
        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            var t1 = new Track("test", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            _competition.Tracks.Enqueue(t1);
            var result = _competition.NextTrack();
            result = _competition.NextTrack();
            Assert.IsNull(result);
        }
        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            var t1 = new Track("test", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            var t2 = new Track("test2", new SectionTypes[] { SectionTypes.StartGrid, SectionTypes.Finish });
            _competition.Tracks.Enqueue(t1);
            _competition.Tracks.Enqueue(t2);
            var result = _competition.NextTrack();
            Assert.AreEqual(t1, result);
            result = _competition.NextTrack();
            Assert.AreEqual(t2, result);
        }
    }
}
