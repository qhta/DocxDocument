namespace DocumentModel.Spreadsheet;

public interface ICacheSource // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public Source? Type { get ; set; }

  public uint? ConnectionId { get ; set; }

  public IWorksheetSource? WorksheetSource { get ; set; }

  public IConsolidation? Consolidation { get ; set; }

  public ICacheSourceExtensionList? CacheSourceExtensionList { get ; set; }

}
