namespace DocumentModel.Wordprocessing;

public partial class NumberingSymbolRunProperties
{
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeRightToLeftText() => RightToLeftText is not null;
}
