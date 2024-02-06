using System;

public interface IFruitProcessor<out T>
{
    T Process();
}

public interface IContravariantFruitProcessor<in T>
{
    void DisplayInfo(T fruit);
}
