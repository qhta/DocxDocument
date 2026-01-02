using DocumentFormat.OpenXml.EMMA;

using DocxEditor.Helpers;

namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel for DocumentModel.DocumentProperties.
/// </summary>
public sealed class DocumentPropertiesVM : ObservableCollection<DocumentPropertyVM>
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="modelCollection"></param>
  public DocumentPropertiesVM(AllDocumentProperties modelCollection)
  {
    ModelCollection = modelCollection;
    ModelCollection.CoreProperties ??= new DocumentModel.CoreProperties(modelCollection.Document!);
    AddKnownProperties();
    CollectionChanged += DocumentPropertiesVM_CollectionChanged;
    //string candidateName = "John";
    //string candidateAddress = "435 East Coast Road";
    //int age = 30;
    //PropertiesProvider.Models.Add("Name", candidateName);
    //PropertiesProvider.Models.Add("Address", candidateAddress);
    //PropertiesProvider.Models.Add("Age", age);
  }

  private void AddKnownProperties()
  {
    foreach (var item in ModelCollection.GetKnownProperties())
    {
      PropertiesProvider.Models.Add(item.Key, item.Value);
      var property = ModelCollection.GetProperty(item.Key);
      if (property == null)
      {
        property = new DocumentProperty(item.Key, item.Value.PropertyType);
      }
      var propertyVM = new DocumentPropertyVM(property);
      Add(propertyVM);
    }
  }

  private void DocumentPropertiesVM_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  {
    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    {
      foreach (DocumentPropertyVM item in e.NewItems!)
      {
        ModelCollection.Add(item.Model);
      }
    }
    else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
    {
      foreach (DocumentPropertyVM item in e.OldItems!)
      {
        ModelCollection.Remove(item.Model);
      }
    }
  }

  /// <summary>
  /// Model collection of document properties.
  /// </summary>
  public DocumentModel.AllDocumentProperties ModelCollection {  get;}

  /// <summary>
  /// Provider for dynamic properties recognition needed by PropertyGrid.
  /// </summary>
  public DocumentPropertiesProvider PropertiesProvider { get;} = new DocumentPropertiesProvider();
}
