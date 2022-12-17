import { Navigation } from '../components/Navigation';

export interface IHomeProps {
  controller: {
    title: string;
  };
}

const Home = ({ controller }: IHomeProps) => {
  return (
    <>
      <Navigation />
      <p>{controller.title}</p>
    </>
  );
};

export default Home;
