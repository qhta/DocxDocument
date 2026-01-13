using System.IO.Packaging;

namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
public class CustomProperties : ElementCollection<CustomDocumentProperty>
{

  internal CP.Properties? CustomFileProperties { get; private set; }


  /// <summary>
  /// Default constructor.
  /// </summary>
  public CustomProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CustomProperties(Wordprocessing.Document document)
  {
    CustomFileProperties = document.WordprocessingDocument?.GetCustomFileProperties();
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Triggered when the underlying document's WordprocessingDocument changes.
  /// </summary>
  /// <param name="sender">Should be the Wordprocessing.Document instance</param>
  /// <param name="e">PropertyChangedEventArgs with propertyName = "WordprocessingDocument"</param>
  /// <remarks>
  /// If new value is null then CustomFileProperties are set to null to avoid errors on properties access.
  /// If new value is not null then CustomFileProperties are updated to the new document's PackageProperties.
  /// </remarks>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (sender is Wordprocessing.Document document)
      if (e.PropertyName == nameof(Wordprocessing.Document.WordprocessingDocument))
      {
        if (document.WordprocessingDocument == null)
        {
          CustomFileProperties = null;
        }
        else
        {
          var isEmpty = CustomFileProperties == null;
          CustomFileProperties = document.WordprocessingDocument?.GetCustomFileProperties();
          if (isEmpty)
            GetValuesFromCustomFileProperties();
          else
            SetValuesToCustomFileProperties();
        }
      }
  }

  /// <summary>
  /// Gets values from CustomFileProperties to this instance.
  /// </summary>
  private void GetValuesFromCustomFileProperties()
  {
    this.Clear();
    foreach (var openXmlCustomDocumentProperty in CustomFileProperties!.ChildElements.Cast<CP.CustomDocumentProperty>())
    {
      var customDocumentProperty = new CustomDocumentProperty(this, openXmlCustomDocumentProperty);
      this.Add(customDocumentProperty); 
    }
  }

  /// <summary>
  /// Sets values from this instance to CustomFileProperties.
  /// </summary>
  private void SetValuesToCustomFileProperties()
  {
    CustomFileProperties!.RemoveAllChildren();
    foreach (var customDocumentProperty in this)
    {
      CustomFileProperties.AppendChild(customDocumentProperty.CreateOpenCustomDocumentProperty());
    }
  }

}