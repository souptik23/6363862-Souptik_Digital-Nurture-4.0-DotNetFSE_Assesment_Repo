import React, { useState } from "react";
import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

function App() {
  const [view, setView] = useState("book");
  const [showCourses, setShowCourses] = useState(true);

  const data = {
    books: [
      { title: "Clean Code", author: "Robert C. Martin" },
      { title: "You Don't Know JS", author: "Kyle Simpson" },
    ],
    blogs: [
      { title: "React Basics", category: "React" },
      { title: "Understanding State", category: "React" },
    ],
    courses: [
      { name: "React Mastery", price: 5999 },
      { name: "JS Fundamentals", price: 3999 },
    ],
  };

  const buttonStyles = {
    padding: "10px 20px",
    margin: "0 10px",
    borderRadius: "5px",
    border: "none",
    backgroundColor: "#3498db",
    color: "white",
    cursor: "pointer",
    transition: "background-color 0.3s",
  };

  const contentMap = {
    book: <BookDetails books={data.books} />,
    blog: <BlogDetails blogs={data.blogs} />,
    course: <CourseDetails courses={data.courses} />,
  };

  return (
    <div
      style={{
        padding: "40px",
        fontFamily: "Segoe UI, Arial",
        maxWidth: "800px",
        margin: "0 auto",
        backgroundColor: "#f5f5f5",
        minHeight: "100vh",
        borderRadius: "10px",
      }}
    >
      <h1
        style={{
          color: "#2c3e50",
          textAlign: "center",
          marginBottom: "30px",
        }}
      >
        🧑‍💻 Learning Hub
      </h1>

      <div
        style={{
          display: "flex",
          justifyContent: "center",
          marginBottom: "30px",
        }}
      >
        {Object.keys(contentMap).map((key) => (
          <button
            key={key}
            onClick={() => setView(key)}
            style={{
              ...buttonStyles,
              backgroundColor: view === key ? "#2980b9" : "#3498db",
            }}
          >
            Show {key.charAt(0).toUpperCase() + key.slice(1)}s
          </button>
        ))}
      </div>

      <div
        style={{
          backgroundColor: "white",
          padding: "20px",
          borderRadius: "8px",
          boxShadow: "0 2px 4px rgba(0,0,0,0.1)",
        }}
      >
        {contentMap[view]}
      </div>

      <hr style={{ margin: "30px 0", border: "1px solid #ddd" }} />

      <button onClick={() => setShowCourses(!showCourses)} style={buttonStyles}>
        {showCourses ? "Hide" : "Show"} Courses
      </button>

      {showCourses && (
        <div
          style={{
            marginTop: "20px",
            backgroundColor: "white",
            padding: "20px",
            borderRadius: "8px",
            boxShadow: "0 2px 4px rgba(0,0,0,0.1)",
          }}
        >
          <CourseDetails courses={data.courses} />
        </div>
      )}

      {view !== "none" && (
        <p
          style={{
            textAlign: "center",
            color: "#7f8c8d",
            marginTop: "20px",
          }}
        >
          Currently viewing: {view.charAt(0).toUpperCase() + view.slice(1)}s
        </p>
      )}
    </div>
  );
}

export default App;