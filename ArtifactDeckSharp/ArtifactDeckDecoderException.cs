﻿using System;

namespace ArtifactDeckSharp
{
    public class ArtifactDeckDecoderException : Exception
    {
        public ArtifactDeckDecoderException()
        {
        }

        public ArtifactDeckDecoderException(string message)
            : base(message)
        {
        }

        public ArtifactDeckDecoderException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
