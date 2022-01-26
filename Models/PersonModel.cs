﻿namespace MongoDBDemo.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

class PersonModel
{
    [BsonId]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressModel PrimaryAddress { get; set; }
    [BsonElement("dob")]
    public DateTime DateOfBirth { get; set; }
}
