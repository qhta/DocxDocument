namespace DocumentModel.InOpenXml.Test
{
	/// <summary>
	/// Comprehensive test for DocumentModel.Rsids.
	/// </summary>
	public static class RsidsTest
	{
		/// <summary>
		/// Runs all Rsids serialization tests.
		/// </summary>
		/// <returns>True if all tests pass; otherwise, false.</returns>
		public static bool Run()
		{
			Console.WriteLine("=== Rsids Test ===\n");
			if (!TestXmlSerialization()) return false;
			if (!TestJsonSerialization()) return false;
			if (!TestEdgeCases()) return false;
			if (!TestStoreInDocument()) return false;
			if (!TestUpdateInDocument()) return false;
			Console.WriteLine("All Rsids tests passed.\n");
			return true;
		}

		/// <summary>
		/// Tests XML serialization and deserialization of Rsids.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestXmlSerialization()
		{
			Console.WriteLine("--- XML Serialization ---");
			var testData = CreateSampleRsids();
			{
				var xmlSerializer = new XmlSerializer(typeof(Rsids));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, testData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Serialized XML:\n" + xmlString);

				Rsids? deserialized;
				using (var stringReader = new StringReader(xmlString))
				{
					deserialized = (Rsids?)xmlSerializer.Deserialize(stringReader);
				}
				if (deserialized == null)
				{
					Console.WriteLine("✗ XML Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
				{
					Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
					return false;
				}
				Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests JSON serialization and deserialization of Rsids.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestJsonSerialization()
		{
			Console.WriteLine("--- JSON Serialization ---");
			var testData = CreateSampleRsids();
			{
        var jsonOptions = JsonConfig.Options;
				string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
				Console.WriteLine("Serialized JSON:\n" + jsonString);

				var deserialized = JsonSerializer.Deserialize<Rsids>(jsonString, jsonOptions);
				if (deserialized == null)
				{
					Console.WriteLine("✗ JSON Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
				{
					Console.WriteLine($"✗ JSON Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
					return false;
				}
				Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests edge cases like empty Rsids object.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		static bool TestEdgeCases()
		{
			Console.WriteLine("--- Edge Cases ---");
			{
				var empty = new Rsids();
				string xml = SerializeToXml(empty);
				var xmlDeserialized = DeserializeFromXml(xml);
				if (xmlDeserialized == null)
				{
					Console.WriteLine("✗ Edge Cases: XML deserialization of empty object failed");
					return false;
				}
				string json = SerializeToJson(empty);
				var jsonDeserialized = DeserializeFromJson(json);
				if (jsonDeserialized == null)
				{
					Console.WriteLine("✗ Edge Cases: JSON deserialization of empty object failed");
					return false;
				}
				Console.WriteLine("✓ Edge case tests passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests setting sample Rsids to a new document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document Rsids can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document Rsids are successfully stored and verified; otherwise, false.</returns>
		static bool TestStoreInDocument()
		{
			Console.WriteLine("--- Store sample Rsids in new document---");
			{
				Rsids testData = CreateSampleRsids();
				using (var document = new Document("temp.docx", FileMode.CreateNew))
				{
					document.Rsids = testData;
				}

				Rsids storedData;
				using (var document = new Document("temp.docx"))
				{
					storedData = document.Rsids ?? throw new InvalidOperationException("Rsids not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(Rsids));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Rsids stored to new document and reloaded from it:\n" + xmlString);

				if (!TestHelper.CompareTestData(testData, storedData, out var propName))
				{
					Console.WriteLine($"✗ Store sample Rsids test FAILED - data mismatch in '{propName}'");
					return false;
				}

				Console.WriteLine("✓ Store sample Rsids test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Tests updating the Rsids of a document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document Rsids can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document Rsids are successfully updated and verified; otherwise, false.</returns>
		static bool TestUpdateInDocument()
		{
			Console.WriteLine("--- Update document Rsids ---");
			{
				Rsids testData = CreateSampleRsids();
				var initialCount = testData.Count;
				using (var document = new Document("temp.docx", FileMode.CreateNew))
				{
					document.Rsids = testData;
    			document.Rsids.Add(Random.Shared.Next() );
				}

				Rsids storedData;
				using (var document = new Document("temp.docx"))
				{
					storedData = document.Rsids ?? throw new InvalidOperationException("Rsids not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(Rsids));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Updated document Rsids:\n" + xmlString);

				var storedCount = storedData.Count;
				if (storedCount != initialCount + 1)
				{
					Console.WriteLine($"✗ Updated document Rsids test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
					return false;
				}

				Console.WriteLine("✓ Updated document Rsids test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Creates a sample Rsids object with various property types.
		/// </summary>
		/// <returns>A populated Rsids object.</returns>
		static Rsids CreateSampleRsids()
		{
			var props = new Rsids();
			for (int i=1; i<=10; i++)
			{
				props.Add(i);
			}
			return props;
		}

		/// <summary>
		/// Serializes a Rsids object to an XML string.
		/// </summary>
		/// <param name="props">The Rsids object to serialize.</param>
		/// <returns>The serialized XML string.</returns>
		static string SerializeToXml(Rsids props)
		{
			var xmlSerializer = new XmlSerializer(typeof(Rsids));
			using (var stringWriter = new StringWriter())
			using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
			{
				xmlSerializer.Serialize(xmlWriter, props);
				return stringWriter.ToString();
			}
		}

		/// <summary>
		/// Deserializes a Rsids object from an XML string.
		/// </summary>
		/// <param name="xml">The XML string to deserialize.</param>
		/// <returns>The deserialized Rsids object, or null if deserialization fails.</returns>
		static Rsids? DeserializeFromXml(string xml)
		{
			var xmlSerializer = new XmlSerializer(typeof(Rsids));
			using (var stringReader = new StringReader(xml))
			{
				return (Rsids?)xmlSerializer.Deserialize(stringReader);
			}
		}

		/// <summary>
		/// Serializes a Rsids object to a JSON string.
		/// </summary>
		/// <param name="props">The Rsids object to serialize.</param>
		/// <returns>The serialized JSON string.</returns>
		static string SerializeToJson(Rsids props)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Serialize(props, jsonOptions);
		}

		/// <summary>
		/// Deserializes a Rsids object from a JSON string.
		/// </summary>
		/// <param name="json">The JSON string to deserialize.</param>
		/// <returns>The deserialized Rsids object, or null if deserialization fails.</returns>
		static Rsids? DeserializeFromJson(string json)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Deserialize<Rsids>(json, jsonOptions);
		}
	}
}