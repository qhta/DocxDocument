namespace DocumentModel.Office2010.Excel;

public interface ITabularSlicerCache // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? PivotCacheId { get ; set; }
  
  public TabularSlicerCacheSortOrder? SortOrder { get ; set; }
  
  public bool? CustomListSort { get ; set; }
  
  public bool? ShowMissing { get ; set; }
  
  public SlicerCacheCrossFilter? CrossFilter { get ; set; }
  
  public ITabularSlicerCacheItems? TabularSlicerCacheItems { get ; set; }
  
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
