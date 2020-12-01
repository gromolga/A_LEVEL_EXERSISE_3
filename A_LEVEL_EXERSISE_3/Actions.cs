using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    public class Actions
    {
        private readonly Logger logger = Logger.getInstance();
        public void Info()
        {
            logger.Info($"Start method: {nameof(Info)}");
        }

        public void Warning()
        {
            logger.Info($"Start method: {nameof(Warning)}");
        }
        public void Error()
        {
            throw new Exception("I broke a toilet");
        }
    }
}
