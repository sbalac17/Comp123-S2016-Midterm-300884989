﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    /*Shivya Balachandran
    Comp123
    06/24/2016
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            int firstNumber = random.Next(1, 49);
            int secondNumber = random.Next(1, 49);
        }
    }
}