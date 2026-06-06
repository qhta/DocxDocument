
namespace DocumentModel.Interop.Core;	
/// <summary>
/// A collection of all Axis objects in the specified chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes?view=office-pia"/>
public interface IAxes: IInteropCollection<IAxis>
{
  /// <summary>
  /// Gets an enumerator for the axes collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes._newenum?view=office-pia"/>
  public object _NewEnum { get; }
}	
