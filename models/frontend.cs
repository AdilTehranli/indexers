namespace learn3.models;

public  class frontend:Developer
{
    private string[] _programing; 


    public frontend(int length)
    {
        _programing = new string[length];
    }
    public string this[int index]
    {
        get 
        {
            if (index > _programing.Length - 1&& index<0)
            {
                throw new ArgumentException();
            }
            return _programing[index]; 
        }
        set
        {
            if (index > _programing.Length - 1 && index < 0)
            {
                throw new ArgumentException();
            }
            _programing[index] = value; 
        }
    }


}