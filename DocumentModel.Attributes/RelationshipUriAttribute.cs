using System;


#nullable enable
namespace DocumentModel.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
  public sealed class RelationshipUriAttribute : Attribute
  {
    public RelationshipUriAttribute(string relationshipType) => this.RelationshipType = relationshipType;

    public string RelationshipType { get; }
  }
}