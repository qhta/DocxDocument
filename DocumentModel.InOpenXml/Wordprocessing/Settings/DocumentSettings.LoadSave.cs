using DocumentModel.OpenXml;

namespace DocumentModel.Wordprocessing;

public partial class DocumentSettings
{
  internal DXWP.Settings OpenXmlSettings { get; private set; } = new DXWP.Settings();

  /// <summary>
  /// Loads the document settings from the specified OpenXmlSettings.
  /// </summary>
  /// <param name="settings">The OpenXmlSettings to load from.</param>
  internal void LoadFromOpenXmlSettings(DXWP.Settings settings)
  {
    OpenXmlSettings = settings;
    foreach (var DXOpenXmlElement in OpenXmlSettings.ChildElements)
    {
      if (KnownProperties.TryGetValue(DXOpenXmlElement.GetType().Name, out var property))
      {
        var value = DXOpenXmlElement.GetObjectByOpenXmlType();
        property.SetValue(this, value);
      }
    }
  }

  /// <summary>
  /// Saves the current document settings to the specified OpenXmlSettings.
  /// </summary>
  /// <param name="settings">The OpenXmlSettings to save to.</param>
  internal void SaveToOpenXmlSettings(DXWP.Settings settings)
  {
    foreach (var property in KnownProperties.Values)
    {
      var value = property.GetValue(this);
      var childElement = settings.ChildElements.FirstOrDefault(element => element.GetType().Name == property.Name);
      if (childElement != null) childElement.Remove();

      if (value != null)
      {
        var DXOpenXmlElement = OpenXmlElementConverter.CreateOpenXmlElementByObjectType(property.Name, value);
        if (DXOpenXmlElement != null)
          settings.AppendChild(DXOpenXmlElement);
      }
    }
  }
}

