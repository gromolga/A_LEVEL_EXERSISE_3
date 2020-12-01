using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    public class Starter
    {
        private readonly Logger logger = Logger.getInstance();
        public void Run()
        {
            Actions actions = new Actions();
            var rand = new Random();

            for (var i = 0; i < 100; i++)
            {
                try
                {
                    switch (rand.Next(1, 3))
                    {
                        case 1:
                            actions.Info();
                            break;
                        case 2:
                            actions.Warning();
                            break;
                        default:
                            actions.Error();
                            break;
                    }
                }
                catch (Exception exception)
                {
                    logger.Error($"Action failed by reason: {exception.StackTrace}");
                }
            }
            var output = logger.GetAllErrors();
            File.WriteAllText("OUTPUT.TXT", output);
        }
    }
}
