using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{

    public class Client: TimerClient{

        public Recipe r;

        public Client(Recipe recipe){
            this.r = recipe;
        }

        public void TimeOut(){
            this.r.SetCooked();
        }


    }

}