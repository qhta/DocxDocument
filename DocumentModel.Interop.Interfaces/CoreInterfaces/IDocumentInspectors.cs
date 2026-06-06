using System.Collections;	
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents a collection of DocumentInspector objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspectors?view=office-pia"/>
public interface IDocumentInspectors: IInteropCollection<IDocumentInspector>
{
}	
