using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    class Actions
    {
        A_LEVEL_EXERSISE_3.Logger logger = A_LEVEL_EXERSISE_3.Logger.getInstance();
        public void Info()
        {
            logger.Info("Start method: Info");
        }

        public void Warning()
        {
            logger.Warning("Skipped logic in method: Warning");
        }
        public void Error()
        {
            logger.Error("I broke a toilet");
        }
    }
}
