namespace DocumentModel.Office2010.Excel;

public interface IOlapSlicerCache // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? PivotCacheId { get ; set; }

  public IOlapSlicerCacheLevelsData? OlapSlicerCacheLevelsData { get ; set; }

  public IOlapSlicerCacheSelections? OlapSlicerCacheSelections { get ; set; }

  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }

}
