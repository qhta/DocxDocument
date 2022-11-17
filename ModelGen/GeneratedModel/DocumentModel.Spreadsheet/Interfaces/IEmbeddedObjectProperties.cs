namespace DocumentModel.Spreadsheet;

public interface IEmbeddedObjectProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Locked { get ; set; }

  public bool? DefaultSize { get ; set; }

  public bool? Print { get ; set; }

  public bool? Disabled { get ; set; }

  public bool? UiObject { get ; set; }

  public bool? AutoFill { get ; set; }

  public bool? AutoLine { get ; set; }

  public bool? AutoPict { get ; set; }

  public string? Macro { get ; set; }

  public string? AltText { get ; set; }

  public bool? Dde { get ; set; }

  public string? Id { get ; set; }

  public IObjectAnchor? ObjectAnchor { get ; set; }

}
