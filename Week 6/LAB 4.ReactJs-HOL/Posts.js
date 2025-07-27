import React from 'react';
import Post from './Post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  componentDidMount() {
    this.loadPosts();
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => {
        this.setState({ posts: data.slice(0, 10) }); // only show first 10 posts
      })
      .catch(error => {
        this.setState({ hasError: true });
        console.error('Fetch error:', error);
      });
  }

  componentDidCatch(error, info) {
    this.setState({ hasError: true });
    alert("An error occurred while rendering posts.");
    console.error("Error caught in componentDidCatch:", error, info);
  }

  render() {
    if (this.state.hasError) {
      return <h2 style={{ color: 'red' }}>Something went wrong while displaying the posts.</h2>;
    }

    return (
      <div style={{ padding: "20px" }}>
        <h2>Blog Posts</h2>
        {this.state.posts.map(post => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;