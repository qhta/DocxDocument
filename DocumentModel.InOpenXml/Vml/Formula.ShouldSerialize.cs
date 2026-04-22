namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Formula
{
  public bool ShouldSerializeEquation() => !String.IsNullOrEmpty(Equation);
}
