using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        void BeginSpinning();

        void PauseSpinning();

        void EndSpinning();

        void SkipForward();

        void SkipBackward();

        void WriteData();

        void ReadData();

        void OutputData();

    }
}
