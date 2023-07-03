class Component
{
    public string id {get; protected set;}
    protected int[] dimensions {get; protected set;}    
}

class CPU : Component
{
    public ArrayList activeProcesses;

    public static CPU Instantiate(string _id, int width, int length){
        CPU cpu = new CPU();
        cpu.id = _id;
        cpu.dimensions[0] = width;
        cpu.dimensions[1] = length;
        return cpu;
    }

    public void Start(){
        activeProcesses = new ArrayList();
    }

    public void AddNewProcess(Process process){
        activeProcesses.Add(process);
    }
}

