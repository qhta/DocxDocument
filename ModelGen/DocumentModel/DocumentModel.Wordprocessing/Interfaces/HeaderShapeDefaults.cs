namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public partial interface HeaderShapeDefaults
{
  public DocumentModel.Vml.ShapeDefaults? ShapeDefaults { get; set; }
  
  public DocumentModel.Vml.ShapeLayout? ShapeLayout { get; set; }
  
}
