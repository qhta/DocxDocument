namespace ModelXmlSchemaApp;

using ModelXmlSchema;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var XmlSchemaParser = new XmlSchemaParser();
    XmlSchemaParser.ParseSchemaFiles(@"D:\VS\Docs\OpenXML\Schemas", @"D:\VS\Docs\OpenXML\XmlSchema.accdb");
    var t2 = DateTime.Now;
    Console.WriteLine("Done in {0} seconds", (int)(t2-t1).TotalSeconds);
    Console.WriteLine("Found {0} files, added {1}", XmlSchemaParser.SchemaFilesTotal, XmlSchemaParser.SchemaFilesAdded);
    Console.WriteLine("Found {0} namespaces, added {1}, updated {2}", XmlSchemaParser.SchemaNamespacesTotal, XmlSchemaParser.SchemaNamespacesAdded, XmlSchemaParser.SchemaNamespacesUpdates);
    Console.WriteLine("Found {0} used namespaces, added {1}", XmlSchemaParser.UsedNamespacesTotal, XmlSchemaParser.UsedNamespacesAdded);
    Console.WriteLine("Found {0} used simple types, added {1}, updated {2}", XmlSchemaParser.SchemaSimpleTypesTotal, XmlSchemaParser. SchemaSimpleTypesAdded, XmlSchemaParser. SchemaSimpleTypesUpdates);
    Console.WriteLine("Found {0} used complex types, added {1}", XmlSchemaParser.SchemaComplexTypesTotal, XmlSchemaParser. SchemaComplexTypesAdded);
    Console.WriteLine("Found {0} used attributes, added {1}, updated {2}", XmlSchemaParser.SchemaAttributesTotal, XmlSchemaParser. SchemaAttributesAdded, XmlSchemaParser. SchemaAttributesUpdates);
    Console.WriteLine("Found {0} used attribute groups, added {1}", XmlSchemaParser.SchemaAttributeGroupsTotal, XmlSchemaParser. SchemaAttributeGroupsAdded);
    Console.WriteLine("Found {0} used attribute group refs, added {1}", XmlSchemaParser.SchemaAttributeGroupRefsTotal, XmlSchemaParser. SchemaAttributeGroupRefsAdded);
    Console.WriteLine("Found {0} used particles, added {1}, updated {2}", XmlSchemaParser.SchemaParticlesTotal, XmlSchemaParser. SchemaParticlesAdded, XmlSchemaParser. SchemaParticlesUpdates);
    Console.WriteLine("Found {0} used enum values, added {1}", XmlSchemaParser.SchemaEnumValuesTotal, XmlSchemaParser. SchemaEnumValuesAdded);
    Console.WriteLine("Found {0} used patterns, added {1}", XmlSchemaParser.SchemaPatternsTotal, XmlSchemaParser. SchemaPatternsAdded);
    Console.WriteLine("Found {0} used list items, added {1}, updated {2}", XmlSchemaParser.SchemaListItemsTotal, XmlSchemaParser. SchemaListItemsAdded, XmlSchemaParser. SchemaListItemsUpdates);
    Console.WriteLine("Found {0} used union members, added {1}, updated {2}", XmlSchemaParser.SchemaUnionMembersTotal, XmlSchemaParser. SchemaUnionMembersAdded, XmlSchemaParser. SchemaUnionMembersUpdates);
    Console.WriteLine("Found {0} used groups, added {1}", XmlSchemaParser.SchemaGroupsTotal, XmlSchemaParser. SchemaGroupsAdded);
    Console.WriteLine("Found {0} used group refs, added {1}, updated {2}", XmlSchemaParser.SchemaGroupRefsTotal, XmlSchemaParser. SchemaGroupRefsAdded, XmlSchemaParser. SchemaGroupRefsUpdates);
    Console.WriteLine("Found {0} used elements, added {1}, updated {2}", XmlSchemaParser.SchemaElementsTotal, XmlSchemaParser. SchemaElementsAdded, XmlSchemaParser. SchemaElementsUpdates);
}
}
