namespace DocumentModel.Office.Word;

public interface IDocEvents // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IEventDocNewXsdString? EventDocNewXsdString { get ; set; }

  public IEventDocOpenXsdString? EventDocOpenXsdString { get ; set; }

  public IEventDocCloseXsdString? EventDocCloseXsdString { get ; set; }

  public IEventDocSyncXsdString? EventDocSyncXsdString { get ; set; }

  public IEventDocXmlAfterInsertXsdString? EventDocXmlAfterInsertXsdString { get ; set; }

  public IEventDocXmlBeforeDeleteXsdString? EventDocXmlBeforeDeleteXsdString { get ; set; }

  public IEventDocContentControlAfterInsertXsdString? EventDocContentControlAfterInsertXsdString { get ; set; }

  public IEventDocContentControlBeforeDeleteXsdString? EventDocContentControlBeforeDeleteXsdString { get ; set; }

  public IEventDocContentControlOnExistXsdString? EventDocContentControlOnExistXsdString { get ; set; }

  public IEventDocContentControlOnEnterXsdString? EventDocContentControlOnEnterXsdString { get ; set; }

  public IEventDocStoreUpdateXsdString? EventDocStoreUpdateXsdString { get ; set; }

  public IEventDocContentControlUpdateXsdString? EventDocContentControlUpdateXsdString { get ; set; }

  public IEventDocBuildingBlockAfterInsertXsdString? EventDocBuildingBlockAfterInsertXsdString { get ; set; }

}
