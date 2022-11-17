namespace DocumentModel.Office.SpreadSheetML.Y2021.ExtLinks2021;

public interface IExternalBookAlternateUrls // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? DriveId { get ; set; }

  public string? ItemId { get ; set; }

  public IAbsoluteUrlAlternateUrl? AbsoluteUrlAlternateUrl { get ; set; }

  public IRelativeUrlAlternateUrl? RelativeUrlAlternateUrl { get ; set; }

}
