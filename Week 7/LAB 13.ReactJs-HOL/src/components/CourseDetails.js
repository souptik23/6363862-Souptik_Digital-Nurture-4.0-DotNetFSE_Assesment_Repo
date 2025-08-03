import React from "react";

function CourseDetails({ courses }) {
  return (
    <div>
      <h2>🎓 Courses</h2>
      <ul>
        {courses.map((course, index) => (
          <li key={index}>
            {course.name} – ₹{course.price}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default CourseDetails;