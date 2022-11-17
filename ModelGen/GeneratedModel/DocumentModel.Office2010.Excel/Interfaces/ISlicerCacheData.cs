namespace DocumentModel.Office2010.Excel;

public interface ISlicerCacheData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IOlapSlicerCache? OlapSlicerCache { get ; set; }

  public ITabularSlicerCache? TabularSlicerCache { get ; set; }

}
