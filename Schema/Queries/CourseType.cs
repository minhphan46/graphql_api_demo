using HotChocolate;
using System.Collections.Generic;
using System;
using GraphQL.API.Models;

namespace GraphQL.API.Schema.Queries
{
    public class CourseType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }

        [GraphQLNonNullType]
        public InstructorType Instructor { get; set; }
        public IEnumerable<StudentType> Students { get; set; }
    }
}
