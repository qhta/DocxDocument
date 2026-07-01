using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of defined styles in a Wordprocessing document.
/// This class provides access to paragraph, character, table, and numbering styles, enabling advanced formatting and style management for document content.
/// </summary>
[OpenXmlType(typeof(DXW.Style))]
[XmlRoot("DefinedStyles", Namespace = "DocumentModel.Wordprocessing")]
//[DirectAccess]
public partial class StyleDefinitions : ModelElementCollection<StyleDefinition, DXW.Styles, DXW.Style>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public StyleDefinitions()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "styles">Model Styles</param>
  /// <param name="openXmlCollection">The OpenXml collection of defined styles.</param>
  public StyleDefinitions(Styles styles, DXW.Styles? openXmlCollection) : base(styles, openXmlCollection)
  {
  }

  /// <summary>
  /// Parent styles element that contains this collection of defined styles. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Styles? Styles => Parent as Styles;

  /// <summary>
  /// Gets updatable element for this collection of defined styles,
  /// which is the <see cref = "DXW.Styles"/> element that contains the individual <see cref = "DXW.Style"/> elements
  /// representing each defined style.
  /// </summary>
  /// <returns></returns>
  public override object? GetUpdatableObject()
  {
    return Styles?.GetUpdatableObject() as DXW.Styles;
  }


  /// <summary>
  /// Updates the styles in the specified OpenXml element by removing all existing styles and adding new styles defined
  /// in the current collection.  
  /// </summary>
  /// <remarks>This method replaces all styles in the target element with those defined in the current
  /// collection. Ensure that the styles being added are properly configured for the document context.</remarks>
  /// <param name = "element">The OpenXml element to update. Must be of type <see cref = "DXW.Styles"/>.</param>
  /// <exception cref = "ArgumentException">Thrown if <paramref name = "element"/> is not of type <see cref = "DXW.Styles"/>.</exception>
  public void UpdateStyles(DX.OpenXmlElement element)
  {
    if (element is not DXW.Styles styles)
      throw new ArgumentException($"Expected element of type {typeof(DXW.Styles).FullName}, but got {element.GetType().FullName}.");
    styles.RemoveAllChildren<DXW.Style>();
    foreach (var styleDef in this)
    {
      var style = OpenXmlElementConverter.ConvertTo(styleDef, typeof(DXW.Style)) as DXW.Style;
      styles.AppendChild(style);
    }
  }

  /// <summary>
  /// Loads styles from the specified OpenXmlElement into the current collection, replacing any existing styles.
  /// </summary>
  /// <remarks>This method clears the current collection before loading new styles. The collection will contain
  /// only the styles loaded from the specified element after the method completes.</remarks>
  /// <param name = "element">The OpenXmlElement containing the styles to load. Must be of type DXW.Styles.</param>
  /// <exception cref = "ArgumentException">Thrown if the provided element is not of type DXW.Styles.</exception>
  public void LoadStyles(DX.OpenXmlElement element)
  {
    if (element is not DXW.Styles styles)
      throw new ArgumentException($"Expected element of type {typeof(DXW.Styles).FullName}, but got {element.GetType().FullName}.");
    SetLoading(true);
    var styleElements = styles.Elements<DXW.Style>().ToArray();
    this.Clear();
    foreach (var style in styleElements)
    {
      var styleDef = OpenXmlElementConverter.ConvertFrom(style, typeof(DMW.StyleDefinition)) as DMW.StyleDefinition;
      this.Add(styleDef!);
    }

    SetLoading(false);
  }
}