using System;

class DoorMachine
{
    private enum State { Locked, Unlocked }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void Unlock()
    {
        if (currentState == State.Locked)
        {
            currentState = State.Unlocked;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void Lock()
    {
        if (currentState == State.Unlocked)
        {
            currentState = State.Locked;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
