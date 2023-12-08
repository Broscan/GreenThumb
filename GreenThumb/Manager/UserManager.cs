using GreenThumb.Database;
using GreenThumb.Models;

namespace GreenThumb.Manager
{
    public static class UserManager
    {
        public static UserModel? CurrentSignedInUser { get; set; }


        public static async Task<bool> SignInUser(string username, string password)
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW gtUow = new(context);
                var allUsers = await gtUow.UserRepository.GetAll();

                UserModel userModel = new UserModel();

                foreach (var user in allUsers)
                {
                    if (user.UserName == username && user.Password == password)
                    {
                        CurrentSignedInUser = user;

                        //CurrentGarden = await gtUow.GardenRepository.GetById(user.UserId);
                        return true;
                    }
                }
                return false;
            }
        }

        public static async Task<bool> ValidateUsername(string username)
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW gtUow = new(context);
                var allUsers = await gtUow.UserRepository.GetAll();

                bool isValidUsername = true;

                foreach (var user in allUsers)
                {
                    if (user.UserName == username)
                    {
                        isValidUsername = false;
                    }
                }

                return isValidUsername;
            }
        }

        public static async Task<bool> RegisterUser(string username, string password)
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW gtUow = new(context);

                if (await ValidateUsername(username))
                {
                    UserModel newUser = new UserModel();
                    newUser.UserName = username;
                    newUser.Password = password;

                    GardenModel newGarden = new();
                    newUser.Garden = newGarden;

                    await gtUow.UserRepository.Add(newUser);
                    await gtUow.Complete();
                    return true;

                }
                return false;
            }
        }


        public static void SignOutUser()
        {
            CurrentSignedInUser = null;
        }

    }
}
