namespace DocumentModel;
/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, and statistic properties. 
/// </summary>
[XmlRoot("BuiltInProperties", Namespace = "DocumentModel")]
public partial class BuiltInProperties : ModelElementCollection<BuiltInProperty>
{
 /// <summary>
 /// Provides access to the core properties of the document.
 /// </summary>
 public CoreProperties CoreProperties { get; private set; }
 /// <summary>
 /// Provides access to the content properties of the document.
 /// </summary>
 public ContentProperties ContentProperties { get; private set; }
 /// <summary>
 /// Provides access to the statistics properties of the document.
 /// </summary>
 public StatisticProperties StatisticProperties { get; private set; }

 /// <summary>
 /// Initializing constructor. Initializes the properties based on the provided document.
 /// </summary>
 /// <param name = "document">The document from which to initialize the properties.</param>
 public BuiltInProperties(DMW.Document document)
 {
  CoreProperties = document.CoreProperties;
  foreach (var property in CoreProperties.KnownProperties.Values)
   Attach(CoreProperties, property);
  ContentProperties = document.ContentProperties;
  foreach (var property in ContentProperties.KnownProperties.Values)
   Attach(ContentProperties, property);
  StatisticProperties = document.StatisticProperties;
  foreach (var property in StatisticProperties.KnownProperties.Values)
   Attach(StatisticProperties, property);
 }

 /// <summary>
 /// Adds a new built-in document property to the collection based on the provided known property model.
 /// </summary>
 /// <param name = "baseObject">The object that contains the property.</param>
 /// <param name = "knownPropertyModel">The known property model to attach.</param>
 private void Attach(object baseObject, PropertyModel knownPropertyModel)
 {
  var propertyInfo = knownPropertyModel.PropertyInfo;
  var builtInAttribute = propertyInfo.GetCustomAttribute<BuiltInPropertyAttribute>();
  if (builtInAttribute != null)
  {
   var DocumentProperty = new BuiltInProperty
   {
    BaseObject = baseObject,
    PropertyInfo = propertyInfo,
    Name = propertyInfo.Name,
   };
   if (DocumentProperty.Type != propertyInfo.PropertyType)
    throw new InvalidOperationException("Property type mismatch.");
   Add(DocumentProperty);
  }
 }
}