using NUnit.Framework;

public class LogicGateTests
{
    [Test]
    public void AND_TrueTrue_ReturnsTrue()
    {
        Assert.IsTrue(LogicGate.Evaluate(GateType.AND, true, true));
    }

    [Test]
    public void AND_TrueFalse_ReturnsFalse()
    {
        Assert.IsFalse(LogicGate.Evaluate(GateType.AND, true, false));
    }

    [Test]
    public void OR_TrueFalse_ReturnsTrue()
    {
        Assert.IsTrue(LogicGate.Evaluate(GateType.OR, true, false));
    }

    [Test]
    public void OR_FalseFalse_ReturnsFalse()
    {
        Assert.IsFalse(LogicGate.Evaluate(GateType.OR, false, false));
    }

    [Test]
    public void NAND_TrueTrue_ReturnsFalse()
    {
        Assert.IsFalse(LogicGate.Evaluate(GateType.NAND, true, true));
    }

    [Test]
    public void NAND_TrueFalse_ReturnsTrue()
    {
        Assert.IsTrue(LogicGate.Evaluate(GateType.NAND, true, false));
    }

    [Test]
    public void NOR_FalseFalse_ReturnsTrue()
    {
        Assert.IsTrue(LogicGate.Evaluate(GateType.NOR, false, false));
    }

    [Test]
    public void NOR_TrueFalse_ReturnsFalse()
    {
        Assert.IsFalse(LogicGate.Evaluate(GateType.NOR, true, false));
    }

    [Test]
    public void XOR_TrueFalse_ReturnsTrue()
    {
        Assert.IsTrue(LogicGate.Evaluate(GateType.XOR, true, false));
    }

    [Test]
    public void XOR_TrueTrue_ReturnsFalse()
    {
        Assert.IsFalse(LogicGate.Evaluate(GateType.XOR, true, true));
    }
}
