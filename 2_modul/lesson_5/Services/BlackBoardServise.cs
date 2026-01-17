using lesson_5.Models;

namespace lesson_5.Services;

public class BlackBoardServise : IBlackBoardService
{
    private List<BlackBoard> BlackBoards;

    public BlackBoardServise()
    {
        BlackBoards = new List<BlackBoard>();
    }

    public Guid AddBlackBoard(BlackBoard blackBoard)
    {
        blackBoard.BlackBoardId = Guid.NewGuid();
        BlackBoards.Add(blackBoard);
        return blackBoard.BlackBoardId;
    }

    public bool DeleteBlackBoard(Guid blackBoardId)
    {
        foreach (var blackBoard in BlackBoards)
        {
            if (blackBoard.BlackBoardId == blackBoardId)
            {
                BlackBoards.Remove(blackBoard);
                return true;
            }
        }

        return false;
    }

    public List<BlackBoard> GetAllBlackBoards()
    {
        return BlackBoards;
    }

    public BlackBoard? GetBlackBoardById(Guid blackBoardId)
    {
        foreach (var blackBoard in BlackBoards)
        {
            if (blackBoard.BlackBoardId == blackBoardId)
            {
                return blackBoard;
            }
        }

        return null;
    }

    public bool UpdateBlackBoard(BlackBoard updatingBlackBoard)
    {
        foreach (var blackBoard in BlackBoards)
        {
            if (blackBoard.BlackBoardId == updatingBlackBoard.BlackBoardId)
            {
                blackBoard.Name = updatingBlackBoard.Name;
                blackBoard.Width = updatingBlackBoard.Width;
                blackBoard.Height = updatingBlackBoard.Height;
                blackBoard.IsActive = updatingBlackBoard.IsActive;
                return true;
            }
        }

        return false;
    }
}
