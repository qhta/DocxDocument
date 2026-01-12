using System.IO.Packaging;

namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
public class CustomProperties : ElementCollection<CustomDocumentProperty>
{
  internal PP.CustomFilePropertiesPart CustomFilePropertiesPart { get; }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="customFileProperties">Package properties from packaging system.</param>
  public CustomProperties(PP.CustomFilePropertiesPart customFileProperties)
  {
    CustomFilePropertiesPart = customFileProperties;
    foreach (var element in 
             CustomFilePropertiesPart.Properties!.ChildElements.OfType<CP.CustomDocumentProperty>())
    {
      {
        Add(new CustomDocumentProperty(this, element));
      }
    }
  }
}