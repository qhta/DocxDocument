using DocumentModel;
using Microsoft.DotNet.DesignTools.ViewModels;
using Qhta.MVVM;

namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel representing a document property.
/// </summary>
public class DocumentPropertyVM: ViewModel<DocumentModel.DocumentProperty>, IPropertyVM  
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="model"></param>
  public DocumentPropertyVM(DocumentProperty model) : base(model)
  {
  }

  /// <summary>
  /// Name of the property.
  /// </summary>
  public string Name
  {
    get => Model.Name ?? string.Empty;
    set => Model.Name = value;
  }

  /// <summary>
  /// Value of the property.
  /// </summary>
  public object? Value
  {
    get => Model.Value;
    set => Model.Value = value;
  }

  /// <summary>
  /// Value type of the property.
  /// </summary>
  public Type ValueType
  {
    get => Model.Type ?? typeof(object);
    set => Model.Type = value;
  }
}