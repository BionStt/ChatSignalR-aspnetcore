using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class PostsController : Controller
{
    private IPostRepository _postRepository { get; set; }

    public PostsController(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public List<Post> GetPosts()
    {
        return _postRepository.GetAll();
    }

    public Post GetPost(int id)
    {
        return _postRepository.GetPost(id);
    }

    public void AddPost([FromBody]Post post)
    {
        _postRepository.AddPost(post);
    }
}
