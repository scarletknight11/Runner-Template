﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace PlayModeTests
{
    public class ApplicationPlayingTests
    {
        [Test]
        public void VerifyApplicationPlaying()
        {
            Assert.That(Application.isPlaying, Is.True);
        }
    }
}
