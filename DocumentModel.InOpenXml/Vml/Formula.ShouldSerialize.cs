namespace DocumentModel.Vml;

public partial class Formula
{
  public bool ShouldSerializeEquation() => Equation is not null;
}
