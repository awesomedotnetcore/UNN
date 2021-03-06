﻿using System;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace UNN
{

    public abstract class Network : IDisposable
    {
        public abstract Signal Predict(ComputeShader compute, Signal input, bool train);

        public abstract float Loss(ComputeShader compute, Signal signal, Signal answer, bool train);

        public abstract float Accuracy(ComputeShader compute, Signal input, Signal answer);

        public abstract void Gradient(ComputeShader compute, Signal input, Signal answer);

        public abstract void Learn(ComputeShader compute, float rate = 0.1f);

        public abstract void Dispose();

    }

}


