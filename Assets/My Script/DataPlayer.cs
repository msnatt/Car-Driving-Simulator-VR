
[System.Serializable]
public class DataPlayer
{
    public DataPlayer() { }
    public DataPlayer(string uname, int uscore)
    {
        this.uname = uname;
        this.uscore = uscore;
    }
    public string uname;
    public int uscore;
}
