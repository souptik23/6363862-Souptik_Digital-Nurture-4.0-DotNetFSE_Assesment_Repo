import React from "react";

function BlogDetails({ blogs }) {
  return (
    <div>
      <h2>📝 Blog Posts</h2>
      <ul>
        {blogs.map((blog, index) => (
          <li key={index}>
            <strong>{blog.title}</strong> – {blog.category}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;