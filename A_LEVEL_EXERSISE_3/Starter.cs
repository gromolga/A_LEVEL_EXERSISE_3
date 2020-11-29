using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_3
{
    class Starter
    {
        public void Run()
        {
            Actions actions = new Actions();
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random();
                var result = rand.Next(1, 3);

                try
                {
                    switch (result)
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
                    Logger.getInstance().Error($"Action failed by reason: {exception.StackTrace}");
                }
            }
        }
    }
}
