namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseTableCellProperties<T> 
{
  public bool ShouldSerializeShading() => Shading is not null;
  public bool ShouldSerializeNoWrap() => NoWrap is not null;
  public bool ShouldSerializeTableCellMargin() => TableCellMargin is not null;
  public bool ShouldSerializeTableCellVerticalAlignment() => TableCellVerticalAlignment is not null;
}
