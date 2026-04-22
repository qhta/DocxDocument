namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class OpenXmlFormulaElement
{
  public bool ShouldSerializeDir() => Dir is not null;
}
