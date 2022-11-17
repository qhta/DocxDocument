namespace DocumentModel.Office2019.Drawing.Animation.Model3D;

public interface IAnimationProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }

  public string? Length { get ; set; }

  public string? Count { get ; set; }

  public bool? Auto { get ; set; }

  public string? Offset { get ; set; }

  public string? St { get ; set; }

  public string? End { get ; set; }

  public DocumentModel.Office2019.Drawing.Animation.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }

}
