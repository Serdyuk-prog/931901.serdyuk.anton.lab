using Lab6.Models;

namespace Lab6.Services
{
    public interface IUserPermissionsService
    {
        Boolean CanEditPost(Post post);

        Boolean CanEditPostComment(PostComment postComment);
    }
}