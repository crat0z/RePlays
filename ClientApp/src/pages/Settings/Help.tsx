import Button from "../../components/Button";
import { postMessage } from "../../helpers/messenger";

interface Props {
}

export const Help: React.FC<Props> = ({}) => {
	return (
    <div className="flex flex-col gap-2 font-medium text-base pb-7"> 
      <h1 className="font-bold text-2xl">Help</h1>
      <span className="font-normal text-sm">Experiencing an issue with RePlays app?</span>

      <span className="text-gray-700 mt-4">Submit an Issue</span>
      <span className="font-normal text-sm">Report a bug on Github.</span>
      <Button text="Github" width={"auto"} onClick={(e) => {postMessage("ShowFolder", "https://github.com/lulzsun/RePlays/issues")}}/>

      <span className="text-gray-700 mt-4">Join Our Community Discord</span>
      <span className="font-normal text-sm">Get help from the RePlays community.</span>
      <Button text="Discord" width={"auto"} onClick={(e) => {postMessage("ShowFolder", "https://discordapp.com/invite/Qj2BmZX")}}/>
    </div>
	)
}

export default Help;