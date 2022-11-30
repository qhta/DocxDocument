namespace DocumentModel.Packaging;

/// <summary>
/// Represents the type of part referenced by a .
/// </summary>
public interface IDataPart // : 
{
  /// <summary>
  /// Gets the public part path in the package.
  /// </summary>
  public System.Uri? Uri { get ; set; }
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the public path to be used for the part name.
  /// </summary>
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets the file base name to be used for the part name in the package.
  /// </summary>
  public System.String? TargetName { get ; set; }
  
  /// <summary>
  /// Gets the file extension to be used for the part in the package.
  /// </summary>
  public System.String? TargetFileExtension { get ; set; }
  
}
