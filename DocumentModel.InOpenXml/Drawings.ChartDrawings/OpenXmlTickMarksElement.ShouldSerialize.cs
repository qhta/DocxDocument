namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class OpenXmlTickMarksElement
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
