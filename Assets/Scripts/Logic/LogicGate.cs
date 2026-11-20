public class LogicGate
{
    public static bool Evaluate(GateType gateType, bool A, bool B)
    {
        switch (gateType)
        {
            case GateType.AND:
                return A && B;
            case GateType.OR:
                return A || B;
            case GateType.NAND:
                return !(A && B);
            case GateType.NOR:
                return !(A || B);
            case GateType.XOR:
                return A ^ B;
            default:
                throw new System.ArgumentException($"Invalid gate type {gateType}");
        }
    }

    public static bool Evaluate(GateType gateType, bool value)
    {
        switch (gateType)
        {
            case GateType.NOT:
                return !value;
            default:
                throw new System.ArgumentException($"Invalid gate type {gateType}");
        }
    }
}
