namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ValueColors
{
  public bool ShouldSerializeMinColorSolidColorFillProperties() => MinColorSolidColorFillProperties is not null;
  public bool ShouldSerializeMidColorSolidColorFillProperties() => MidColorSolidColorFillProperties is not null;
  public bool ShouldSerializeMaxColorSolidColorFillProperties() => MaxColorSolidColorFillProperties is not null;
}
