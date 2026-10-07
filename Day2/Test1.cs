using System;
public interface IPlay
{
    int play();      //function declaration
    
}

public class chess : IPlay
{
  //explicit 

  int IPlay.play()  // Explicit Interface   ------> always go for explicit 
  {
    return 40;
  }
   public int play()
    {
        return 12;
    }
}

public class cricket : IPlay
{
   //implicit --> there is chnaces of ambiguity of smae method name .

   public int play()
    {
        return 22;
    }

    
}

